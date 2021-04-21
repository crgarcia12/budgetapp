import React from 'react';
import { Stack, Text, Link, FontWeights } from 'office-ui-fabric-react';

import logo from './fabric.png';
import ExpensesList from './components/ExpensesList/ExpensesList';

const boldStyle = {
  root: { fontWeight: FontWeights.semibold }
};

export const App: React.FunctionComponent = () => {
  return (
    <Stack
      horizontalAlign="center"
      verticalAlign="center"
      verticalFill
      styles={{
        root: {
          width: '960px',
          margin: '0 auto',
          textAlign: 'center',
          color: '#605e5c'
        }
      }}
      gap={15}
    >
      <Text variant="xxLarge" styles={boldStyle}>
        Welcome to Your UI Fabric App
      </Text>

      <ExpensesList/>
    </Stack>
  );
};
